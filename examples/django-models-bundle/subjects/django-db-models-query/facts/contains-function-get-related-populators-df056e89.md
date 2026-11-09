# Fact df056e89

Store id: 3da7d143-20e5-469f-8ce0-95c4e165a17a

## Text

```text
contains function get_related_populators
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::get_related_populators](../../django-db-models-query-get-related-populators/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":3090,"symbol":"get_related_populators"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3da7d143-20e5-469f-8ce0-95c4e165a17a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3472900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 3090,
        "symbol": "get_related_populators"
      },
      "rel": "contains",
      "target": "3d28dc8e-d374-41f3-af2f-d2f0379018f0"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_related_populators"
}
```
