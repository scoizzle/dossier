# Fact 620f6cd4

Store id: c3c73eb5-6354-400d-8d72-cfb70d2dcc3a

## Text

```text
contains class StringAgg
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
- posted_at: `2026-11-09T22:39:40.0505810+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/aggregates::StringAgg](../../django-db-models-aggregates-stringagg/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":371,"symbol":"StringAgg"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c3c73eb5-6354-400d-8d72-cfb70d2dcc3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0505810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 371,
        "symbol": "StringAgg"
      },
      "rel": "contains",
      "target": "1cb1fc0e-ee2d-46e2-9577-4cb7a0047f22"
    }
  ],
  "status": "live",
  "subject_id": "d72d5420-abde-4439-aadc-c9ebfdcfd755",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class StringAgg"
}
```
