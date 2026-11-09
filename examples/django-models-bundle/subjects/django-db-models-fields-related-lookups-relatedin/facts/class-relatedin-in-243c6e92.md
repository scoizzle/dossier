# Fact 243c6e92

Store id: 885772f3-ba5f-41ad-ad89-5107e2c719ec

## Text

```text
class RelatedIn(In)
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
- posted_at: `2026-11-09T22:39:45.0985780+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 42,
  "symbol": "RelatedIn"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L95","symbol":"RelatedIn"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 42,
    "symbol": "RelatedIn"
  },
  "id": "885772f3-ba5f-41ad-ad89-5107e2c719ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.0985780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L95",
        "symbol": "RelatedIn"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "2bae8be9-43a0-47f8-827d-2c44deca62bd",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedIn(In)"
}
```
