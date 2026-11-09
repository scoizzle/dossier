# Fact dbc38ac3

Store id: 8cb39b39-4a7e-4f73-89fd-8524eb2b8c0f

## Text

```text
def get_related_populators(klass_info, select, db, fetch_mode)
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
- posted_at: `2026-11-09T23:44:56.3439640+00:00`

## Data

```json
{
  "end_line": 3096,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 3090,
  "symbol": "get_related_populators"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":3090,"selector":"L3090-L3096","symbol":"get_related_populators"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_related_populators](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 3096,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 3090,
    "symbol": "get_related_populators"
  },
  "id": "8cb39b39-4a7e-4f73-89fd-8524eb2b8c0f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3439640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 3090,
        "selector": "L3090-L3096",
        "symbol": "get_related_populators"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3d28dc8e-d374-41f3-af2f-d2f0379018f0",
  "subject_name": "django/db/models/query::get_related_populators",
  "tags": [
    "entity:function"
  ],
  "text": "def get_related_populators(klass_info, select, db, fetch_mode)"
}
```
