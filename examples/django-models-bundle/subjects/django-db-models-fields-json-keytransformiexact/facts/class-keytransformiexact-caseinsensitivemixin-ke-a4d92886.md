# Fact a4d92886

Store id: 513c03ad-c413-4b5f-8bb0-cf8dbcb7d916

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
- posted_at: `2026-11-09T23:44:51.0470520+00:00`

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
  "id": "513c03ad-c413-4b5f-8bb0-cf8dbcb7d916",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0470520+00:00"
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
  "subject_id": "a867292c-b72b-4501-91bd-4b5ba858f19b",
  "subject_name": "django/db/models/fields/json::KeyTransformIExact",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIExact( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IExact )"
}
```
