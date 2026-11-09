# Fact 9c999188

Store id: e35dd22f-017c-475f-8239-ccdf0b000b96

## Text

```text
def cached_col(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.9891360+00:00`

## Data

```json
{
  "end_line": 595,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 591,
  "symbol": "Field.cached_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":591,"selector":"L591-L595","symbol":"Field.cached_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.cached_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 595,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 591,
    "symbol": "Field.cached_col"
  },
  "id": "e35dd22f-017c-475f-8239-ccdf0b000b96",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9891360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 591,
        "selector": "L591-L595",
        "symbol": "Field.cached_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bbfee56b-6b1b-4aff-91d0-1cfb441c6d4f",
  "subject_name": "django/db/models/fields/__init__::Field.cached_col",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cached_col(self)"
}
```
