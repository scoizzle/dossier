# Fact 50892e28

Store id: 932cca43-9768-410a-b5c2-7fe543399620

## Text

```text
def error_messages(self)
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
- posted_at: `2026-11-09T22:39:42.3104350+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 806,
  "symbol": "Field.error_messages"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":806,"selector":"L806-L812","symbol":"Field.error_messages"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.error_messages](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 806,
    "symbol": "Field.error_messages"
  },
  "id": "932cca43-9768-410a-b5c2-7fe543399620",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3104350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 806,
        "selector": "L806-L812",
        "symbol": "Field.error_messages"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fb75614e-7c18-4c98-a019-406ce53ef989",
  "subject_name": "django/db/models/fields/__init__::Field.error_messages",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def error_messages(self)"
}
```
