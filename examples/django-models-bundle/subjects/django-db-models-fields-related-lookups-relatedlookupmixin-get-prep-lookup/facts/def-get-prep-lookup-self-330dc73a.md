# Fact 330dc73a

Store id: 799877a1-ce40-472f-a32d-d7f46bf9f8cf

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
- posted_at: `2026-11-09T23:44:52.2523600+00:00`

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
  "id": "799877a1-ce40-472f-a32d-d7f46bf9f8cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2523600+00:00"
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
  "subject_id": "e9ac333e-59e5-4047-a4f7-272dca372e4b",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
