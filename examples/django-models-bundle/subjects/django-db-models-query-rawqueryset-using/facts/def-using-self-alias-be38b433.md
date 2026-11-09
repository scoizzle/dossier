# Fact be38b433

Store id: 046f477a-5849-46f5-b318-137cb4f7a181

## Text

```text
def using(self, alias)
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
- posted_at: `2026-11-09T23:44:56.2662680+00:00`

## Data

```json
{
  "end_line": 2537,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2527,
  "symbol": "RawQuerySet.using"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2527,"selector":"L2527-L2537","symbol":"RawQuerySet.using"}`

## Items

```json
[
  {
    "text": "Select the database this RawQuerySet should execute against.",
    "locator": {
      "line": 2528
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.using](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2537,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2527,
    "symbol": "RawQuerySet.using"
  },
  "id": "046f477a-5849-46f5-b318-137cb4f7a181",
  "items": [
    {
      "locator": {
        "line": 2528
      },
      "text": "Select the database this RawQuerySet should execute against."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2662680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2527,
        "selector": "L2527-L2537",
        "symbol": "RawQuerySet.using"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "eb2b50f2-e45a-4ffd-9205-d84591ac0976",
  "subject_name": "django/db/models/query::RawQuerySet.using",
  "tags": [
    "entity:method"
  ],
  "text": "def using(self, alias)"
}
```
