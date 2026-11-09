# Fact ec606817

Store id: aefadd5b-4e05-4e83-8e61-4196348b5bf3

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
- posted_at: `2026-11-09T23:31:56.5217030+00:00`

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
  "id": "aefadd5b-4e05-4e83-8e61-4196348b5bf3",
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
    "posted_at": "2026-11-09T23:31:56.5217030+00:00"
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
  "subject_id": "f9de01da-fa8a-40a0-b57c-1ac49aa3aa36",
  "subject_name": "django/db/models/fields/__init__::Field.has_default",
  "tags": [
    "entity:method"
  ],
  "text": "def has_default(self)"
}
```
