# Fact 88f92adf

Store id: 0d0f82d6-66c8-40d9-89d1-90ea9118ab9b

## Text

```text
def get_source_fields(self)
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
- posted_at: `2026-11-09T23:31:55.9530700+00:00`

## Data

```json
{
  "end_line": 1687,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1685,
  "symbol": "When.get_source_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1685,"selector":"L1685-L1687","symbol":"When.get_source_fields"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.get_source_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1687,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1685,
    "symbol": "When.get_source_fields"
  },
  "id": "0d0f82d6-66c8-40d9-89d1-90ea9118ab9b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9530700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1685,
        "selector": "L1685-L1687",
        "symbol": "When.get_source_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a5c427fa-de27-45a8-b6e4-ad86c52342d5",
  "subject_name": "django/db/models/expressions::When.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
