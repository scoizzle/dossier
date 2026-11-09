# Fact 883b0a2d

Store id: 4e2dae6a-5cbb-4d74-9717-32ea3d4251cd

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:44:58.5567690+00:00`

## Data

```json
{
  "end_line": 192,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 182,
  "symbol": "RawQuery.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":182,"selector":"L182-L192","symbol":"RawQuery.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 192,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 182,
    "symbol": "RawQuery.__iter__"
  },
  "id": "4e2dae6a-5cbb-4d74-9717-32ea3d4251cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5567690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 182,
        "selector": "L182-L192",
        "symbol": "RawQuery.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "58765183-dbb6-429c-affd-e4c78c144118",
  "subject_name": "django/db/models/sql/query::RawQuery.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
