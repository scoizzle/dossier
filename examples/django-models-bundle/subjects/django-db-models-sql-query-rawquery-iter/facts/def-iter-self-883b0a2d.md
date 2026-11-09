# Fact 883b0a2d

Store id: da5aaae0-1943-49a5-83bc-93a599a00c97

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
- posted_at: `2026-11-09T23:32:06.7178360+00:00`

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
  "id": "da5aaae0-1943-49a5-83bc-93a599a00c97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7178360+00:00"
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
  "subject_id": "157f4ed6-bd21-484d-94c0-72d5baba4419",
  "subject_name": "django/db/models/sql/query::RawQuery.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
