# Fact 353d06be

Store id: d766522a-3c11-47ec-a840-6472927d6553

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
- posted_at: `2026-11-09T23:44:48.4077660+00:00`

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
  "id": "d766522a-3c11-47ec-a840-6472927d6553",
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
        "line": 295,
        "symbol": "Count"
      },
      "rel": "contains",
      "target": "65080d62-812b-4b74-92c1-60c43628e75a"
    }
  ],
  "status": "live",
  "subject_id": "6bc5f39c-532b-45f7-9f53-5325c9016e4d",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Count"
}
```
