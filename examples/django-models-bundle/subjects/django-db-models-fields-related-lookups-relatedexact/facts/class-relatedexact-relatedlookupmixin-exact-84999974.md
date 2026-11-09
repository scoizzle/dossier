# Fact 84999974

Store id: d3938739-fb0e-466c-b5a4-0a04ff3d1fa6

## Text

```text
class RelatedExact(RelatedLookupMixin, Exact)
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
- posted_at: `2026-11-09T23:31:59.9928990+00:00`

## Data

```json
{
  "end_line": 132,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 131,
  "symbol": "RelatedExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L132","symbol":"RelatedExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 132,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 131,
    "symbol": "RelatedExact"
  },
  "id": "d3938739-fb0e-466c-b5a4-0a04ff3d1fa6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9928990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L132",
        "symbol": "RelatedExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "62ca3d54-9703-4b54-9e7d-4e4f62d7e2a0",
  "subject_name": "django/db/models/fields/related_lookups::RelatedExact",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedExact(RelatedLookupMixin, Exact)"
}
```
