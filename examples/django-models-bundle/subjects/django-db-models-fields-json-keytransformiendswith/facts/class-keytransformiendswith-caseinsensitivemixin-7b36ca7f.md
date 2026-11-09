# Fact 7b36ca7f

Store id: 95af17dc-b596-4b9a-bd27-ab50cd3a063a

## Text

```text
class KeyTransformIEndsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IEndsWith )
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.7502150+00:00`

## Data

```json
{
  "end_line": 707,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 704,
  "symbol": "KeyTransformIEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":704,"selector":"L704-L707","symbol":"KeyTransformIEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 707,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 704,
    "symbol": "KeyTransformIEndsWith"
  },
  "id": "95af17dc-b596-4b9a-bd27-ab50cd3a063a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7502150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 704,
        "selector": "L704-L707",
        "symbol": "KeyTransformIEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "59cb7c1b-f611-40c4-af30-d64b710df925",
  "subject_name": "django/db/models/fields/json::KeyTransformIEndsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIEndsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IEndsWith )"
}
```
