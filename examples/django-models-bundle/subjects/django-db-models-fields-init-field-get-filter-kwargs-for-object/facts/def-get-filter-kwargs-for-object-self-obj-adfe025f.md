# Fact adfe025f

Store id: 000428e5-7db9-41d4-85c4-ad2ef231f900

## Text

```text
def get_filter_kwargs_for_object(self, obj)
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
- posted_at: `2026-11-09T23:44:50.0301370+00:00`

## Data

```json
{
  "end_line": 1013,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1008,
  "symbol": "Field.get_filter_kwargs_for_object"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1008,"selector":"L1008-L1013","symbol":"Field.get_filter_kwargs_for_object"}`

## Items

```json
[
  {
    "text": "Return a dict that when passed as kwargs to self.model.filter(), would yield all instances having the same value for this field as obj has.",
    "locator": {
      "line": 1009
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_filter_kwargs_for_object](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1013,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1008,
    "symbol": "Field.get_filter_kwargs_for_object"
  },
  "id": "000428e5-7db9-41d4-85c4-ad2ef231f900",
  "items": [
    {
      "locator": {
        "line": 1009
      },
      "text": "Return a dict that when passed as kwargs to self.model.filter(), would yield all instances having the same value for this field as obj has."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0301370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1008,
        "selector": "L1008-L1013",
        "symbol": "Field.get_filter_kwargs_for_object"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c20a86cf-73ce-48bd-bb35-a32e55ad8d00",
  "subject_name": "django/db/models/fields/__init__::Field.get_filter_kwargs_for_object",
  "tags": [
    "entity:method"
  ],
  "text": "def get_filter_kwargs_for_object(self, obj)"
}
```
