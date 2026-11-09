# Fact 4daed894

Store id: 0d45168d-28cd-4c0c-ab26-c241296b130d

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
- posted_at: `2026-11-09T22:39:49.1814420+00:00`

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
  "id": "0d45168d-28cd-4c0c-ab26-c241296b130d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.1814420+00:00"
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
  "subject_id": "1bc85a72-2eed-40b8-8dfd-e90ebc97cb14",
  "subject_name": "django/db/models/query::BaseIterable._async_generator",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def _async_generator(self)"
}
```
