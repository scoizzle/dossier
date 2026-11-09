# Fact 5c7d04a1

Store id: 7f8a5b4b-d1a8-4772-b1dd-414cbfe8efe5

## Text

```text
def _check_ignored_options(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.6363680+00:00`

## Data

```json
{
  "end_line": 1596,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1558,
  "symbol": "ManyToManyField._check_ignored_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1558,"selector":"L1558-L1596","symbol":"ManyToManyField._check_ignored_options"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_ignored_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1596,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1558,
    "symbol": "ManyToManyField._check_ignored_options"
  },
  "id": "7f8a5b4b-d1a8-4772-b1dd-414cbfe8efe5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6363680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1558,
        "selector": "L1558-L1596",
        "symbol": "ManyToManyField._check_ignored_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "53171d74-0424-4389-b6d8-3478c89c11d7",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_ignored_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_ignored_options(self, **kwargs)"
}
```
