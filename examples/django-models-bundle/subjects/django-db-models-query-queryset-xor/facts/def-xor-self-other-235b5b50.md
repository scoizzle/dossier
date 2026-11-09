# Fact 235b5b50

Store id: 5ffea648-ac2b-4c05-8f92-3c7f303bcbf7

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
- posted_at: `2026-11-09T23:44:55.8731210+00:00`

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
  "id": "5ffea648-ac2b-4c05-8f92-3c7f303bcbf7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8731210+00:00"
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
  "subject_id": "ca6cab45-bd89-4645-8f13-d50edba5c9da",
  "subject_name": "django/db/models/query::QuerySet.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
