# Fact 3686fa20

Store id: 8daf588e-8802-4ddd-b4e7-74af6d81091a

## Text

```text
def flatchoices(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.0466190+00:00`

## Data

```json
{
  "end_line": 1137,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1134,
  "symbol": "Field.flatchoices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1134,"selector":"L1134-L1137","symbol":"Field.flatchoices"}`

## Items

```json
[
  {
    "text": "Flattened version of choices tuple.",
    "locator": {
      "line": 1136
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.flatchoices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1137,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1134,
    "symbol": "Field.flatchoices"
  },
  "id": "8daf588e-8802-4ddd-b4e7-74af6d81091a",
  "items": [
    {
      "locator": {
        "line": 1136
      },
      "text": "Flattened version of choices tuple."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0466190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1134,
        "selector": "L1134-L1137",
        "symbol": "Field.flatchoices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a8b8ca59-9710-4b94-8c26-bc654373a390",
  "subject_name": "django/db/models/fields/__init__::Field.flatchoices",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def flatchoices(self)"
}
```
