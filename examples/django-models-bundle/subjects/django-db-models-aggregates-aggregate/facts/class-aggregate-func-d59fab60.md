# Fact d59fab60

Store id: 8efd6dc5-9121-43f4-a84a-ac191c1f1ec7

## Text

```text
class Aggregate(Func)
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
- posted_at: `2026-11-09T23:31:53.5314070+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 75,
  "symbol": "Aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":75,"selector":"L75-L223","symbol":"Aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 75,
    "symbol": "Aggregate"
  },
  "id": "8efd6dc5-9121-43f4-a84a-ac191c1f1ec7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5314070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 75,
        "selector": "L75-L223",
        "symbol": "Aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "575226a6-1aaa-407b-b3c9-d38b1b99ced5",
  "subject_name": "django/db/models/aggregates::Aggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class Aggregate(Func)"
}
```
