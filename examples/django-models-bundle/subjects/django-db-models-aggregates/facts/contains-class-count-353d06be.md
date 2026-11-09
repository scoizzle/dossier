# Fact 353d06be

Store id: 3792f29f-8234-4242-9cd0-218d7e67607d

## Text

```text
contains class Count
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
  - target: [django/db/models/aggregates::Count](../../django-db-models-aggregates-count/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":295,"symbol":"Count"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3792f29f-8234-4242-9cd0-218d7e67607d",
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
        "line": 295,
        "symbol": "Count"
      },
      "rel": "contains",
      "target": "bcd3907f-cca0-4ee9-93a9-4ec8de62b68f"
    }
  ],
  "status": "live",
  "subject_id": "b5feecb6-d0e1-4e7f-8b00-717f9dabceb1",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Count"
}
```
