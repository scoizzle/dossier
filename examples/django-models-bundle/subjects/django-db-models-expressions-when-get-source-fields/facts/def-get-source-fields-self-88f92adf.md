# Fact 88f92adf

Store id: bf9efc38-3b0c-4fbd-809c-0b74bdc38c10

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
- posted_at: `2026-11-09T22:39:41.6970390+00:00`

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
  "id": "bf9efc38-3b0c-4fbd-809c-0b74bdc38c10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6970390+00:00"
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
  "subject_id": "07922736-32b8-4698-9967-b8576da30703",
  "subject_name": "django/db/models/expressions::When.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
