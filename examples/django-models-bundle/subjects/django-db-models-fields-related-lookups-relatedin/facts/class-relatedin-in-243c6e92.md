# Fact 243c6e92

Store id: f17eb7ee-9b11-4e9c-b758-a8d98ea2eff5

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
- posted_at: `2026-11-09T23:31:59.9741190+00:00`

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
  "id": "f17eb7ee-9b11-4e9c-b758-a8d98ea2eff5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9741190+00:00"
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
  "subject_id": "d5adbd9c-969e-41db-af24-ca4d73c45051",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedIn(In)"
}
```
