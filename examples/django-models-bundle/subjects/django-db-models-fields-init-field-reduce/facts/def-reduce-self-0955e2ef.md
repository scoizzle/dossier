# Fact 0955e2ef

Store id: 79780641-360d-4a05-af98-a6fff43cc545

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:44:50.0002300+00:00`

## Data

```json
{
  "end_line": 785,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 764,
  "symbol": "Field.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":764,"selector":"L764-L785","symbol":"Field.__reduce__"}`

## Items

```json
[
  {
    "text": "Pickling should return the model._meta.fields instance of the field, not a new copy of that field. So, use the app registry to load the model and then the field back.",
    "locator": {
      "line": 765
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 785,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 764,
    "symbol": "Field.__reduce__"
  },
  "id": "79780641-360d-4a05-af98-a6fff43cc545",
  "items": [
    {
      "locator": {
        "line": 765
      },
      "text": "Pickling should return the model._meta.fields instance of the field, not a new copy of that field. So, use the app registry to load the model and then the field back."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0002300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 764,
        "selector": "L764-L785",
        "symbol": "Field.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d3c1ce69-2507-4dd4-b133-e01164401bda",
  "subject_name": "django/db/models/fields/__init__::Field.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
