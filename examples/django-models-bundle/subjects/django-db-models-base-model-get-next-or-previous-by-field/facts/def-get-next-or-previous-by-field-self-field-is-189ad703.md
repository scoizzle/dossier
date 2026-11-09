# Fact 189ad703

Store id: 9852906a-1ab9-4ea6-bf5f-5f5aaf85d240

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
- posted_at: `2026-11-09T22:39:40.3453470+00:00`

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
  "id": "9852906a-1ab9-4ea6-bf5f-5f5aaf85d240",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3453470+00:00"
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
  "subject_id": "7bdc12c1-d28b-4acd-bb00-b297272c4a40",
  "subject_name": "django/db/models/base::Model._get_next_or_previous_by_FIELD",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_next_or_previous_by_FIELD(self, field, is_next, **kwargs)"
}
```
