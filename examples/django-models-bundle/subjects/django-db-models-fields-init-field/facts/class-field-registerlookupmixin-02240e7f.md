# Fact 02240e7f

Store id: 76e651d0-b458-4687-821b-b7f237109fae

## Text

```text
class Field(RegisterLookupMixin)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:total_ordering`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9527790+00:00`

## Data

```json
{
  "end_line": 1197,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 127,
  "symbol": "Field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":127,"selector":"L127-L1197","symbol":"Field"}`

## Items

```json
[
  {
    "text": "Base class for all field types",
    "locator": {
      "line": 129
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1197,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 127,
    "symbol": "Field"
  },
  "id": "76e651d0-b458-4687-821b-b7f237109fae",
  "items": [
    {
      "locator": {
        "line": 129
      },
      "text": "Base class for all field types"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9527790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 127,
        "selector": "L127-L1197",
        "symbol": "Field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "13ea5fe5-f7c1-4766-840c-857be074ce31",
  "subject_name": "django/db/models/fields/__init__::Field",
  "tags": [
    "entity:class",
    "decorator:total_ordering"
  ],
  "text": "class Field(RegisterLookupMixin)"
}
```
