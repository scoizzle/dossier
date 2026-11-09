# Fact 5791b1ee

Store id: 79dc0206-ed21-44ce-9969-78646420557d

## Text

```text
def get_extra_restriction(self, alias, related_alias)
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
- posted_at: `2026-11-09T23:44:51.5471360+00:00`

## Data

```json
{
  "end_line": 889,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 877,
  "symbol": "ForeignObject.get_extra_restriction"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":877,"selector":"L877-L889","symbol":"ForeignObject.get_extra_restriction"}`

## Items

```json
[
  {
    "text": "Return a pair condition used for joining and subquery pushdown. The condition is something that responds to as_sql(compiler, connection) method.",
    "locator": {
      "line": 878
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_extra_restriction](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 889,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 877,
    "symbol": "ForeignObject.get_extra_restriction"
  },
  "id": "79dc0206-ed21-44ce-9969-78646420557d",
  "items": [
    {
      "locator": {
        "line": 878
      },
      "text": "Return a pair condition used for joining and subquery pushdown. The condition is something that responds to as_sql(compiler, connection) method."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5471360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 877,
        "selector": "L877-L889",
        "symbol": "ForeignObject.get_extra_restriction"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "87396546-18d5-454f-9cbb-2914f4d56cf0",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_extra_restriction",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_restriction(self, alias, related_alias)"
}
```
