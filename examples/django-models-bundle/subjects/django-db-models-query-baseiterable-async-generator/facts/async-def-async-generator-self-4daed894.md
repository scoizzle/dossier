# Fact 4daed894

Store id: 065bd981-0052-4cf3-92d3-b62ca10a7fa3

## Text

```text
async def _async_generator(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.7627440+00:00`

## Data

```json
{
  "end_line": 107,
  "entity_kind": "method",
  "parent": "BaseIterable",
  "start_line": 93,
  "symbol": "BaseIterable._async_generator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":93,"selector":"L93-L107","symbol":"BaseIterable._async_generator"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable._async_generator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 107,
    "entity_kind": "method",
    "parent": "BaseIterable",
    "start_line": 93,
    "symbol": "BaseIterable._async_generator"
  },
  "id": "065bd981-0052-4cf3-92d3-b62ca10a7fa3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7627440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 93,
        "selector": "L93-L107",
        "symbol": "BaseIterable._async_generator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "713482b6-aca9-483b-be08-3121401cba4b",
  "subject_name": "django/db/models/query::BaseIterable._async_generator",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def _async_generator(self)"
}
```
