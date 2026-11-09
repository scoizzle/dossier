# Fact f72999a6

Store id: b203d7de-d70d-46e6-905b-31b23be5016a

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
- posted_at: `2026-11-09T23:45:00.0584150+00:00`

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
  "id": "b203d7de-d70d-46e6-905b-31b23be5016a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0584150+00:00"
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
  "subject_id": "db434afe-867f-4053-8700-4d7d07851a9c",
  "subject_name": "django/db/models/utils::create_namedtuple_class.__reduce__",
  "tags": [
    "entity:function"
  ],
  "text": "def __reduce__(self)"
}
```
