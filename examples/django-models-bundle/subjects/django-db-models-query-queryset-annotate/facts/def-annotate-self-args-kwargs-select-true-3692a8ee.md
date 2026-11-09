# Fact 3692a8ee

Store id: fa81ef8e-b5a4-400b-b170-2fc04867db0f

## Text

```text
def _annotate(self, args, kwargs, select=True)
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
- posted_at: `2026-11-09T22:39:49.6550830+00:00`

## Data

```json
{
  "end_line": 1932,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1876,
  "symbol": "QuerySet._annotate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1876,"selector":"L1876-L1932","symbol":"QuerySet._annotate"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._annotate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1932,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1876,
    "symbol": "QuerySet._annotate"
  },
  "id": "fa81ef8e-b5a4-400b-b170-2fc04867db0f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6550830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1876,
        "selector": "L1876-L1932",
        "symbol": "QuerySet._annotate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "9ced119c-7388-4b8e-a4b3-c2076eadd4a3",
  "subject_name": "django/db/models/query::QuerySet._annotate",
  "tags": [
    "entity:method"
  ],
  "text": "def _annotate(self, args, kwargs, select=True)"
}
```
