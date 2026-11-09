# Fact 36fde108

Store id: 0f53f721-e42e-4b2e-87cc-8cb7b27b1cee

## Text

```text
contains class PreventQuerySetCloning
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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::PreventQuerySetCloning](../../django-db-models-query-preventquerysetcloning/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":342,"symbol":"PreventQuerySetCloning"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0f53f721-e42e-4b2e-87cc-8cb7b27b1cee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8716240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 342,
        "symbol": "PreventQuerySetCloning"
      },
      "rel": "contains",
      "target": "e115e634-7fb6-44a8-a762-6f714e648e3d"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PreventQuerySetCloning"
}
```
