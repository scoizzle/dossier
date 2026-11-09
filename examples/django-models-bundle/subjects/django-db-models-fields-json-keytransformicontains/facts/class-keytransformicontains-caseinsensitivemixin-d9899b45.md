# Fact d9899b45

Store id: 8fdb9d81-a732-4c7e-9169-765cd9f20f13

## Text

```text
class KeyTransformIContains( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IContains )
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
- posted_at: `2026-11-09T22:39:43.7425360+00:00`

## Data

```json
{
  "end_line": 687,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 684,
  "symbol": "KeyTransformIContains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":684,"selector":"L684-L687","symbol":"KeyTransformIContains"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIContains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 687,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 684,
    "symbol": "KeyTransformIContains"
  },
  "id": "8fdb9d81-a732-4c7e-9169-765cd9f20f13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7425360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 684,
        "selector": "L684-L687",
        "symbol": "KeyTransformIContains"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "15f125e3-20e7-4596-bfac-afe96b25fd93",
  "subject_name": "django/db/models/fields/json::KeyTransformIContains",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIContains( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IContains )"
}
```
