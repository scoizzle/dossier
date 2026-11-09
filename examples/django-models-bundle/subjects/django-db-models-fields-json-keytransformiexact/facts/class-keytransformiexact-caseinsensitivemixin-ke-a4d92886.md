# Fact a4d92886

Store id: d77da97d-a0ed-4989-93de-98f398df4a07

## Text

```text
class KeyTransformIExact( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IExact )
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
- posted_at: `2026-11-09T22:39:43.7385030+00:00`

## Data

```json
{
  "end_line": 681,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 666,
  "symbol": "KeyTransformIExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":666,"selector":"L666-L681","symbol":"KeyTransformIExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 681,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 666,
    "symbol": "KeyTransformIExact"
  },
  "id": "d77da97d-a0ed-4989-93de-98f398df4a07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7385030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 666,
        "selector": "L666-L681",
        "symbol": "KeyTransformIExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "551b2bf2-ec96-44b8-98ab-75510eee714f",
  "subject_name": "django/db/models/fields/json::KeyTransformIExact",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIExact( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IExact )"
}
```
