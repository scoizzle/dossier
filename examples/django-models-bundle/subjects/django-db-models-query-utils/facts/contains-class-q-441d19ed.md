# Fact 441d19ed

Store id: 35c53f0b-b986-4c20-af8a-5d1ca90af100

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
- posted_at: `2026-11-09T23:44:56.7745430+00:00`

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
  "id": "35c53f0b-b986-4c20-af8a-5d1ca90af100",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7745430+00:00"
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
      "target": "bf69ee04-6f46-454c-a386-d9845c43546e"
    }
  ],
  "status": "live",
  "subject_id": "c4182f55-5c15-42df-8e00-aa953309eedf",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Q"
}
```
