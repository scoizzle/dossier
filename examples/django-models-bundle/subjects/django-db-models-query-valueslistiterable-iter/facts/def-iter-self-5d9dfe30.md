# Fact 5d9dfe30

Store id: ea0626fe-07fd-4e27-84c4-c3b7f1ad1bac

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
- posted_at: `2026-11-09T23:32:04.2704920+00:00`

## Data

```json
{
  "end_line": 301,
  "entity_kind": "method",
  "parent": "ValuesListIterable",
  "start_line": 293,
  "symbol": "ValuesListIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":293,"selector":"L293-L301","symbol":"ValuesListIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::ValuesListIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 301,
    "entity_kind": "method",
    "parent": "ValuesListIterable",
    "start_line": 293,
    "symbol": "ValuesListIterable.__iter__"
  },
  "id": "ea0626fe-07fd-4e27-84c4-c3b7f1ad1bac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2704920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 293,
        "selector": "L293-L301",
        "symbol": "ValuesListIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b5bc0f14-2cee-4940-80ea-327c2407b2fa",
  "subject_name": "django/db/models/query::ValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
