# Fact 35de8e2e

Store id: d952b2ba-8882-4594-a0e0-85c3b10fd3e0

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
- posted_at: `2026-11-09T22:39:45.1012770+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "RelatedIn",
  "start_line": 43,
  "symbol": "RelatedIn.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":43,"selector":"L43-L84","symbol":"RelatedIn.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIn.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "RelatedIn",
    "start_line": 43,
    "symbol": "RelatedIn.get_prep_lookup"
  },
  "id": "d952b2ba-8882-4594-a0e0-85c3b10fd3e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1012770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 43,
        "selector": "L43-L84",
        "symbol": "RelatedIn.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a419e39d-cf34-4b00-a914-999316f70360",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIn.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
