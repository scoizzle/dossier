# Fact 752789ec

Store id: d58054c5-ec2f-44e0-b03d-7aa14f8d0ca7

## Text

```text
def __getstate__(self)
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
- posted_at: `2026-11-09T23:44:55.8401020+00:00`

## Data

```json
{
  "end_line": 427,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 424,
  "symbol": "QuerySet.__getstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":424,"selector":"L424-L427","symbol":"QuerySet.__getstate__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__getstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 427,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 424,
    "symbol": "QuerySet.__getstate__"
  },
  "id": "d58054c5-ec2f-44e0-b03d-7aa14f8d0ca7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8401020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 424,
        "selector": "L424-L427",
        "symbol": "QuerySet.__getstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "262fb10a-a522-43d5-a1d9-9a0d2260d474",
  "subject_name": "django/db/models/query::QuerySet.__getstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __getstate__(self)"
}
```
