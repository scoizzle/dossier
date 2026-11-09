# Fact 701b72704d9d85a3-2

Store id: d697b1d7-5a52-430a-acfa-ee33059a760b

## Text

```text
contains class Empty
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
- posted_at: `2026-11-09T23:44:58.2955640+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/datastructures::Empty](../../django-db-models-sql-datastructures-empty/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "d697b1d7-5a52-430a-acfa-ee33059a760b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.2955640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 23,
        "symbol": "Empty"
      },
      "rel": "contains",
      "target": "e678db37-a16e-4c1a-a8c2-a8100ebe065f"
    }
  ],
  "status": "live",
  "subject_id": "a61dfdc2-4877-4b53-a0ac-6fd76c6f4abb",
  "subject_name": "django/db/models/sql/datastructures",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Empty"
}
```
