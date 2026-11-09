# Fact 3430ed88

Store id: 9abdd076-b260-428f-831f-fcdc12531185

## Text

```text
def __aiter__(self)
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
- posted_at: `2026-11-09T23:44:55.8532760+00:00`

## Data

```json
{
  "end_line": 484,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 476,
  "symbol": "QuerySet.__aiter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":476,"selector":"L476-L484","symbol":"QuerySet.__aiter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__aiter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 484,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 476,
    "symbol": "QuerySet.__aiter__"
  },
  "id": "9abdd076-b260-428f-831f-fcdc12531185",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8532760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 476,
        "selector": "L476-L484",
        "symbol": "QuerySet.__aiter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "dcfb877a-b4d4-47bc-bfa2-0d54c60d2911",
  "subject_name": "django/db/models/query::QuerySet.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
