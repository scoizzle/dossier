# Fact a8990f3b

Store id: 357e0bb0-0812-45c1-8d9e-0c5028e047f9

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:51.5241560+00:00`

## Data

```json
{
  "end_line": 780,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 747,
  "symbol": "ForeignObject.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":747,"selector":"L747-L780","symbol":"ForeignObject.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 780,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 747,
    "symbol": "ForeignObject.deconstruct"
  },
  "id": "357e0bb0-0812-45c1-8d9e-0c5028e047f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5241560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 747,
        "selector": "L747-L780",
        "symbol": "ForeignObject.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "b417b627-6d75-4258-8c19-c2aee7cd982c",
  "subject_name": "django/db/models/fields/related::ForeignObject.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
