# Fact 620f6cd4

Store id: c547ab09-4ff4-4c89-a84a-774b0bc87cff

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
- posted_at: `2026-11-09T23:44:48.4077660+00:00`

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
  "id": "c547ab09-4ff4-4c89-a84a-774b0bc87cff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4077660+00:00"
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
      "target": "0c0c09fc-5775-49f0-8a66-5eda3afa4173"
    }
  ],
  "status": "live",
  "subject_id": "6bc5f39c-532b-45f7-9f53-5325c9016e4d",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class StringAgg"
}
```
