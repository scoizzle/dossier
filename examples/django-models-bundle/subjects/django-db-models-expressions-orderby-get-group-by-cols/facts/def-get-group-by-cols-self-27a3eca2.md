# Fact 27a3eca2

Store id: 240749d3-7a46-4f22-8fd4-5756f66b55dc

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:31:55.9939780+00:00`

## Data

```json
{
  "end_line": 2001,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1997,
  "symbol": "OrderBy.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1997,"selector":"L1997-L2001","symbol":"OrderBy.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2001,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1997,
    "symbol": "OrderBy.get_group_by_cols"
  },
  "id": "240749d3-7a46-4f22-8fd4-5756f66b55dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9939780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1997,
        "selector": "L1997-L2001",
        "symbol": "OrderBy.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "96b9f7d4-3a31-4bf6-bccc-d490b8ba0892",
  "subject_name": "django/db/models/expressions::OrderBy.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
