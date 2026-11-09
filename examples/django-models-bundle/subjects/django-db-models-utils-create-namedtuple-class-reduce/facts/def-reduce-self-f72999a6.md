# Fact f72999a6

Store id: fc7f8a57-aea6-40c9-ad53-f3148e47849f

## Text

```text
def __reduce__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.9332450+00:00`

## Data

```json
{
  "end_line": 46,
  "entity_kind": "function",
  "parent": "create_namedtuple_class",
  "start_line": 45,
  "symbol": "create_namedtuple_class.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":45,"selector":"L45-L46","symbol":"create_namedtuple_class.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/utils::create_namedtuple_class.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 46,
    "entity_kind": "function",
    "parent": "create_namedtuple_class",
    "start_line": 45,
    "symbol": "create_namedtuple_class.__reduce__"
  },
  "id": "fc7f8a57-aea6-40c9-ad53-f3148e47849f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9332450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 45,
        "selector": "L45-L46",
        "symbol": "create_namedtuple_class.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "6ce91142-da3a-4992-9267-53e10966f89e",
  "subject_name": "django/db/models/utils::create_namedtuple_class.__reduce__",
  "tags": [
    "entity:function"
  ],
  "text": "def __reduce__(self)"
}
```
