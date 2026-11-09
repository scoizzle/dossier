# Fact dda3ec41

Store id: 41405762-465c-40a1-82d9-77f46ee673f9

## Text

```text
def _get_FIELD_display(self, field)
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
- posted_at: `2026-11-09T22:39:40.3448950+00:00`

## Data

```json
{
  "end_line": 1351,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1345,
  "symbol": "Model._get_FIELD_display"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1345,"selector":"L1345-L1351","symbol":"Model._get_FIELD_display"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._get_FIELD_display](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1351,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1345,
    "symbol": "Model._get_FIELD_display"
  },
  "id": "41405762-465c-40a1-82d9-77f46ee673f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3448950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1345,
        "selector": "L1345-L1351",
        "symbol": "Model._get_FIELD_display"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "bead0ef1-c324-4256-898d-e9ff6e777e03",
  "subject_name": "django/db/models/base::Model._get_FIELD_display",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_FIELD_display(self, field)"
}
```
