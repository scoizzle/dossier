# Fact e85f98d6

Store id: d66bada2-d850-4fb5-8c8e-1791167ae661

## Text

```text
def __new__(cls, *args, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.2493370+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 21,
  "symbol": "BaseManager.__new__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":21,"selector":"L21-L25","symbol":"BaseManager.__new__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__new__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 21,
    "symbol": "BaseManager.__new__"
  },
  "id": "d66bada2-d850-4fb5-8c8e-1791167ae661",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2493370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 21,
        "selector": "L21-L25",
        "symbol": "BaseManager.__new__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "71b81bca-2b66-4807-b28a-656725a91d32",
  "subject_name": "django/db/models/manager::BaseManager.__new__",
  "tags": [
    "entity:method"
  ],
  "text": "def __new__(cls, *args, **kwargs)"
}
```
