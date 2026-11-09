# Fact 81b094cd

Store id: 706dcbd1-9ada-44b9-b28d-821e18519be2

## Text

```text
def PROTECT(collector, field, sub_objs, using)
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
- posted_at: `2026-11-09T23:44:48.8991140+00:00`

## Data

```json
{
  "end_line": 44,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 34,
  "symbol": "PROTECT"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L44","symbol":"PROTECT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::PROTECT](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 44,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 34,
    "symbol": "PROTECT"
  },
  "id": "706dcbd1-9ada-44b9-b28d-821e18519be2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.8991140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L44",
        "symbol": "PROTECT"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "fa59e2eb-4a8d-454c-979b-8e2699123cfc",
  "subject_name": "django/db/models/deletion::PROTECT",
  "tags": [
    "entity:function"
  ],
  "text": "def PROTECT(collector, field, sub_objs, using)"
}
```
