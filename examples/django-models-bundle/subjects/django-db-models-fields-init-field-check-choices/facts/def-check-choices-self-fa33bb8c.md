# Fact fa33bb8c

Store id: dd349f32-89bf-46b4-94a1-e1535d8a6f7b

## Text

```text
def _check_choices(self)
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
- posted_at: `2026-11-09T23:31:56.4286020+00:00`

## Data

```json
{
  "end_line": 423,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 350,
  "symbol": "Field._check_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":350,"selector":"L350-L423","symbol":"Field._check_choices"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 423,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 350,
    "symbol": "Field._check_choices"
  },
  "id": "dd349f32-89bf-46b4-94a1-e1535d8a6f7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4286020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 350,
        "selector": "L350-L423",
        "symbol": "Field._check_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4fc4a96c-d999-45d1-a0a6-052fb1ae9c4e",
  "subject_name": "django/db/models/fields/__init__::Field._check_choices",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_choices(self)"
}
```
