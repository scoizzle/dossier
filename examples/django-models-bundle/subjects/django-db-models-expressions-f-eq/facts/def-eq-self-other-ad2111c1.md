# Fact ad2111c1

Store id: bbee3217-de57-44d3-b847-0809a8e15045

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:31:55.8376770+00:00`

## Data

```json
{
  "end_line": 937,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 936,
  "symbol": "F.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":936,"selector":"L936-L937","symbol":"F.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 937,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 936,
    "symbol": "F.__eq__"
  },
  "id": "bbee3217-de57-44d3-b847-0809a8e15045",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8376770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 936,
        "selector": "L936-L937",
        "symbol": "F.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ec89ec71-7a99-4f8b-9eda-f911672b189d",
  "subject_name": "django/db/models/expressions::F.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
