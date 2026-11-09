# Fact 84999974

Store id: df63d6af-1254-46aa-a8df-179020baa4ff

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
- posted_at: `2026-11-09T22:39:45.1129710+00:00`

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
  "id": "df63d6af-1254-46aa-a8df-179020baa4ff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1129710+00:00"
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
  "subject_id": "4b87b5e6-a2cb-438c-b20b-c231de654518",
  "subject_name": "django/db/models/fields/related_lookups::RelatedExact",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedExact(RelatedLookupMixin, Exact)"
}
```
