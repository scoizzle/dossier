# Fact fb594d84

Store id: fa9f6155-ea57-451f-99de-67cfb85e48e6

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:32:04.2640450+00:00`

## Data

```json
{
  "end_line": 284,
  "entity_kind": "method",
  "parent": "ValuesIterable",
  "start_line": 266,
  "symbol": "ValuesIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":266,"selector":"L266-L284","symbol":"ValuesIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::ValuesIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 284,
    "entity_kind": "method",
    "parent": "ValuesIterable",
    "start_line": 266,
    "symbol": "ValuesIterable.__iter__"
  },
  "id": "fa9f6155-ea57-451f-99de-67cfb85e48e6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2640450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 266,
        "selector": "L266-L284",
        "symbol": "ValuesIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "135f2986-099a-4b96-bc17-f88733773675",
  "subject_name": "django/db/models/query::ValuesIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
