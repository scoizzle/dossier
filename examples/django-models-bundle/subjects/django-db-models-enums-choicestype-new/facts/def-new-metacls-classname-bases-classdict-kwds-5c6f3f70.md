# Fact 5c6f3f70

Store id: d74ce90a-4543-4854-8a84-e6696c6bc3a4

## Text

```text
def __new__(metacls, classname, bases, classdict, **kwds)
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
- posted_at: `2026-11-09T23:31:55.4949340+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 13,
  "symbol": "ChoicesType.__new__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L33","symbol":"ChoicesType.__new__"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.__new__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 13,
    "symbol": "ChoicesType.__new__"
  },
  "id": "d74ce90a-4543-4854-8a84-e6696c6bc3a4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.4949340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L33",
        "symbol": "ChoicesType.__new__"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "ecde5b10-4c58-462c-81dc-982af9d12717",
  "subject_name": "django/db/models/enums::ChoicesType.__new__",
  "tags": [
    "entity:method"
  ],
  "text": "def __new__(metacls, classname, bases, classdict, **kwds)"
}
```
