# Fact 441d19ed

Store id: 9706893d-d157-4ee6-ba2e-c810ca8d6858

## Text

```text
contains class Q
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
- posted_at: `2026-11-09T22:39:50.2075540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query_utils::Q](../../django-db-models-query-utils-q/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":41,"symbol":"Q"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "9706893d-d157-4ee6-ba2e-c810ca8d6858",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.2075540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 41,
        "symbol": "Q"
      },
      "rel": "contains",
      "target": "ae45f348-5418-4c1b-8790-325c14960d82"
    }
  ],
  "status": "live",
  "subject_id": "37abb0c2-46cb-4f07-a1c9-39d94326e8fb",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Q"
}
```
