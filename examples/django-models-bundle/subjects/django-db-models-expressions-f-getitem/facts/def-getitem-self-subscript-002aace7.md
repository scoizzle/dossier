# Fact 002aace7

Store id: 29ad820a-de9c-4e0e-95b6-269c1badc3f4

## Text

```text
def __getitem__(self, subscript)
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
- posted_at: `2026-11-09T23:44:49.4731250+00:00`

## Data

```json
{
  "end_line": 898,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 897,
  "symbol": "F.__getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":897,"selector":"L897-L898","symbol":"F.__getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 898,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 897,
    "symbol": "F.__getitem__"
  },
  "id": "29ad820a-de9c-4e0e-95b6-269c1badc3f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4731250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 897,
        "selector": "L897-L898",
        "symbol": "F.__getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b405aac4-de28-42cd-8705-658292a130eb",
  "subject_name": "django/db/models/expressions::F.__getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getitem__(self, subscript)"
}
```
