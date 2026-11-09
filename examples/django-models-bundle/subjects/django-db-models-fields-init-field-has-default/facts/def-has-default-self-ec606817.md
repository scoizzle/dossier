# Fact ec606817

Store id: bb5045e7-489d-46c6-b873-2eaca2f92e02

## Text

```text
def has_default(self)
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
- posted_at: `2026-11-09T22:39:42.3464130+00:00`

## Data

```json
{
  "end_line": 1055,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1053,
  "symbol": "Field.has_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1053,"selector":"L1053-L1055","symbol":"Field.has_default"}`

## Items

```json
[
  {
    "text": "Return a boolean of whether this field has a default value.",
    "locator": {
      "line": 1054
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.has_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1055,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1053,
    "symbol": "Field.has_default"
  },
  "id": "bb5045e7-489d-46c6-b873-2eaca2f92e02",
  "items": [
    {
      "locator": {
        "line": 1054
      },
      "text": "Return a boolean of whether this field has a default value."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3464130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1053,
        "selector": "L1053-L1055",
        "symbol": "Field.has_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0c31bd4c-5873-45a8-babd-746ee1cf4811",
  "subject_name": "django/db/models/fields/__init__::Field.has_default",
  "tags": [
    "entity:method"
  ],
  "text": "def has_default(self)"
}
```
