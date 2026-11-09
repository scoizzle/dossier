# Fact 620f6cd4

Store id: 98ba10c9-4fa3-4e52-b67e-88dfbadd7ac1

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
- posted_at: `2026-11-09T23:31:53.5507770+00:00`

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
  "id": "98ba10c9-4fa3-4e52-b67e-88dfbadd7ac1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5507770+00:00"
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
      "target": "bcaaf417-5b29-4378-a770-eecf68af8121"
    }
  ],
  "status": "live",
  "subject_id": "b5feecb6-d0e1-4e7f-8b00-717f9dabceb1",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class StringAgg"
}
```
