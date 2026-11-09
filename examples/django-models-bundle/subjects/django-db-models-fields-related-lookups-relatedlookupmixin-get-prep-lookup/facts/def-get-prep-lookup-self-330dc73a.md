# Fact 330dc73a

Store id: ebe8a6c8-92fe-43db-bd97-30e648131517

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
- posted_at: `2026-11-09T23:31:59.9870060+00:00`

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
  "id": "ebe8a6c8-92fe-43db-bd97-30e648131517",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9870060+00:00"
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
  "subject_id": "1913fb61-d56f-4192-905f-dc8bfddb209c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
