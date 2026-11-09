# Fact 235b5b50

Store id: 673edda6-46e7-4246-b7f7-e8fe6a51a9e4

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T23:32:04.3575790+00:00`

## Data

```json
{
  "end_line": 578,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 561,
  "symbol": "QuerySet.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":561,"selector":"L561-L578","symbol":"QuerySet.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 578,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 561,
    "symbol": "QuerySet.__xor__"
  },
  "id": "673edda6-46e7-4246-b7f7-e8fe6a51a9e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3575790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 561,
        "selector": "L561-L578",
        "symbol": "QuerySet.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f646554f-50e4-4de6-86c9-bcaf93929a9d",
  "subject_name": "django/db/models/query::QuerySet.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
