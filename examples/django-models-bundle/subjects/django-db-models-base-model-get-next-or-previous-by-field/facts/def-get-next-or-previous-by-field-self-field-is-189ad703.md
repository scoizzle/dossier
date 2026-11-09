# Fact 189ad703

Store id: 6f6750ec-5c48-4c04-8262-3e3b12e1e428

## Text

```text
def _get_next_or_previous_by_FIELD(self, field, is_next, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7517870+00:00`

## Data

```json
{
  "end_line": 1372,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1353,
  "symbol": "Model._get_next_or_previous_by_FIELD"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1353,"selector":"L1353-L1372","symbol":"Model._get_next_or_previous_by_FIELD"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_next_or_previous_by_FIELD](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1372,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1353,
    "symbol": "Model._get_next_or_previous_by_FIELD"
  },
  "id": "6f6750ec-5c48-4c04-8262-3e3b12e1e428",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7517870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1353,
        "selector": "L1353-L1372",
        "symbol": "Model._get_next_or_previous_by_FIELD"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "89f3df16-4a6d-4498-ad8d-f83e697d5cca",
  "subject_name": "django/db/models/base::Model._get_next_or_previous_by_FIELD",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_next_or_previous_by_FIELD(self, field, is_next, **kwargs)"
}
```
