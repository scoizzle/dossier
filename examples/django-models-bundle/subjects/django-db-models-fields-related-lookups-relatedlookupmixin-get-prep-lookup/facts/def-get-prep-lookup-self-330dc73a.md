# Fact 330dc73a

Store id: 5a80652b-83a5-42a8-9952-c5eaa3ef79a1

## Text

```text
def get_prep_lookup(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:45.1084560+00:00`

## Data

```json
{
  "end_line": 115,
  "entity_kind": "method",
  "parent": "RelatedLookupMixin",
  "start_line": 99,
  "symbol": "RelatedLookupMixin.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L115","symbol":"RelatedLookupMixin.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedLookupMixin.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 115,
    "entity_kind": "method",
    "parent": "RelatedLookupMixin",
    "start_line": 99,
    "symbol": "RelatedLookupMixin.get_prep_lookup"
  },
  "id": "5a80652b-83a5-42a8-9952-c5eaa3ef79a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1084560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L115",
        "symbol": "RelatedLookupMixin.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b4b07c2c-3154-43f5-bde3-dab3c5888407",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
