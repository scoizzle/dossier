# Fact 7b36ca7f

Store id: 6852eba3-29d5-4c16-b416-280392c72821

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
- posted_at: `2026-11-09T23:44:51.0573980+00:00`

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
  "id": "6852eba3-29d5-4c16-b416-280392c72821",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0573980+00:00"
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
  "subject_id": "016812a7-9cb7-46a3-b8bf-ddfa0b2b6e50",
  "subject_name": "django/db/models/fields/json::KeyTransformIEndsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIEndsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IEndsWith )"
}
```
